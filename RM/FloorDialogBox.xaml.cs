﻿#region Namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using Autodesk.Revit.DB.Architecture;
using System.Globalization;
using System.Resources;
#endregion


namespace RM
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class FloorsFinishesControl : Window
    {
        private Document _doc;
        private UIDocument _UIDoc;

        public readonly FloorsFinishesSetup FloorsFinishesSetup;

        public FloorsFinishesControl(UIDocument UIDoc, FloorsFinishesSetup floorsFinishesSetup)
        {
            InitializeComponent();
            _doc = UIDoc.Document;
            _UIDoc = UIDoc;
            FloorsFinishesSetup = floorsFinishesSetup;

            //Fill out Text in form
            this.Title = Util.LangResMan.GetString("floorFinishes_TaskDialogName", Util.Cult);
            this.all_rooms_radio.Content = Util.LangResMan.GetString("roomFinishes_all_rooms_radio", Util.Cult);
            this.floor_height_radio.Content = Util.LangResMan.GetString("floorFinishes_height_label", Util.Cult);
            this.height_param_radio.Content = Util.LangResMan.GetString("floorFinishes_height_param_label", Util.Cult);
            this.groupboxName.Header = Util.LangResMan.GetString("floorFinishes_groupboxName", Util.Cult);
            this.select_floor_label.Content = Util.LangResMan.GetString("floorFinishes_select_floor_label", Util.Cult);
            this.selected_rooms_radio.Content = Util.LangResMan.GetString("roomFinishes_selected_rooms_radio", Util.Cult);
            this.Cancel_Button.Content = Util.LangResMan.GetString("roomFinishes_Cancel_Button", Util.Cult);
            this.Ok_Button.Content = Util.LangResMan.GetString("roomFinishes_OK_Button", Util.Cult);

            //Select the floor type in the document
            IEnumerable<FloorType> floorTypes = from elem in new FilteredElementCollector(_doc).OfClass(typeof(FloorType))
                                               let type = elem as FloorType
                                               where type.IsFoundationSlab == false
                                               select type;

            floorTypes = floorTypes.OrderBy(floorType => floorType.Name);

            // Bind ArrayList with the ListBox
            FloorTypeListBox.ItemsSource = floorTypes;
            FloorTypeListBox.SelectedItem = FloorTypeListBox.Items[0];

            //Find a room
            IList<Element> roomList = new FilteredElementCollector(_doc).OfCategory(BuiltInCategory.OST_Rooms).ToList();

            if (roomList.Count != 0)
            {
                //Get all double parameters
                Room room = roomList.First() as Room;

                List<Parameter> doubleParam = (from Parameter p in room.Parameters 
                                               where p.Definition.ParameterType == ParameterType.Length
                                               select p).ToList();

                paramSelector.ItemsSource = doubleParam;
                paramSelector.DisplayMemberPath = "Definition.Name";
                paramSelector.SelectedIndex = 0;
            }
            else
            {
                paramSelector.IsEnabled = false;
                height_param_radio.IsEnabled = false;
            }

            

        }

        private void Ok_Button_Click(object sender, RoutedEventArgs e)
        {
            if (floor_height_radio.IsChecked == true)
            {
                FloorsFinishesSetup.RoomParameter = null;
                if (Util.GetValueFromString(Height_TextBox.Text, _doc.GetUnits()) != null)
                {
                    FloorsFinishesSetup.FloorHeight = (double)Util.GetValueFromString(Height_TextBox.Text, _doc.GetUnits());

                    if (FloorTypeListBox.SelectedItem != null)
                    {
                        //Select wall type for skirting board
                        FloorsFinishesSetup.SelectedFloorType = FloorTypeListBox.SelectedItem as FloorType;

                        this.DialogResult = true;
                        this.Close();

                        //Select the rooms
                        FloorsFinishesSetup.SelectedRooms = SelectRooms().ToList();
                    }
                }
                else
                {
                    TaskDialog.Show(Util.LangResMan.GetString("floorFinishes_TaskDialogName", Util.Cult),
                        Util.LangResMan.GetString("floorFinishes_heightValueError", Util.Cult), TaskDialogCommonButtons.Close, TaskDialogResult.Close);
                    this.Activate();
                }
            }
            else
            {
                FloorsFinishesSetup.RoomParameter = paramSelector.SelectedItem as Parameter;

                if (FloorTypeListBox.SelectedItem != null)
                {
                    //Select floor type
                    FloorsFinishesSetup.SelectedFloorType = FloorTypeListBox.SelectedItem as FloorType;

                    this.DialogResult = true;
                    this.Close();

                    //Select the rooms
                    FloorsFinishesSetup.SelectedRooms = SelectRooms().ToList();
                }
            }
        }

        private void Cancel_Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

        private IEnumerable<Room> SelectRooms()
        {
            //Create a set of selected elements ids
            ICollection<ElementId> selectedObjectsIds = _UIDoc.Selection.GetElementIds();

            //Create a set of rooms
            IEnumerable<Room> ModelRooms = null;
            IList<Room> tempList = new List<Room>();

            if (all_rooms_radio.IsChecked.Value)
            {
                // Find all rooms in current view
                ModelRooms = from elem in new FilteredElementCollector(_doc, _doc.ActiveView.Id).OfClass(typeof(SpatialElement))
                             let room = elem as Room
                             select room;
            }
            else
            {
                if (selectedObjectsIds.Count != 0)
                {
                    // Find all rooms in selection
                    ModelRooms = from elem in new FilteredElementCollector(_doc, selectedObjectsIds).OfClass(typeof(SpatialElement))
                                 let room = elem as Room
                                 select room;
                    tempList = ModelRooms.ToList();
                }

                if (tempList.Count == 0)
                {
                    //Create a selection filter on rooms
                    ISelectionFilter filter = new RoomSelectionFilter();

                    IList<Reference> rs = _UIDoc.Selection.PickObjects(ObjectType.Element, filter,
                        Util.LangResMan.GetString("roomFinishes_SelectRooms", Util.Cult));

                    foreach (Reference r in rs)
                    {
                        tempList.Add(_doc.GetElement(r) as Room);
                    }

                    ModelRooms = tempList;
                }
            }

            return ModelRooms;
        }

        private void Height_TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Util.GetValueFromString(Height_TextBox.Text, _doc.GetUnits()) != null)
            {
                FloorsFinishesSetup.FloorHeight = (double)Util.GetValueFromString(Height_TextBox.Text, _doc.GetUnits());

                Height_TextBox.Text = UnitFormatUtils.Format(_doc.GetUnits(), UnitType.UT_Length, FloorsFinishesSetup.FloorHeight, true, true);
            }
            else
            {
                TaskDialog.Show(Util.LangResMan.GetString("roomFinishes_TaskDialogName", Util.Cult),
                    Util.LangResMan.GetString("roomFinishes_heightValueError", Util.Cult), TaskDialogCommonButtons.Close, TaskDialogResult.Close);
                this.Activate();
            }
        }
        public class RoomSelectionFilter : ISelectionFilter//TODOЖнеобходимо потом удалить после появления пола
        {
            public bool AllowElement(Element element)
            {
                if (element.Category.Id.IntegerValue == (int)BuiltInCategory.OST_Rooms)
                {
                    return true;
                }
                return false;
            }

            public bool AllowReference(Reference refer, XYZ point)
            {
                return false;
            }
        }

    }
}
