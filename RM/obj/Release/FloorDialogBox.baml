   M S B A M L   `   `   `  ���� G  CUIFramework, Version=20.0.0.0, Culture=neutral, PublicKeyToken=nullX;clr-namespace:UIFramework.PropertyGrid;assembly=UIFrameworkUIFramework.PropertyGrid   RM   RM.FloorDialogBox   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     TPropertyGrid;clr-namespace:UIFramework.PropertyGrid;assembly=UIFramework     {�.   � Title$  Create rooms finishes�� � ShowInTaskbar .   � WindowStartupLocation$ CenterScreen=�#��� ��#��� ��$	��389��$	��516��$	��550��$	��500��$	��900��$
��1200�� � DataContext ��  � 	Resources  �� 
TargetType �� Property �� Value��%�   '��       '	� V     �� " ��.���  � ��$ 88����  � ��$ 22����  � ��$ 	10,10,0,0q��� " 	�.���  � ��$ 0,5,0,5q�.��� $��
10,10,10,5q�.+��� $��	0,0,0,115q�$��60��$��Bottom=�#��� ��$��60��.+�	� -    	�Name$ allRoomsRadio��$��all_rooms_radio��	 d� 	IsChecked$
	 TrueY�$��10,5,0,5q�	� -   $ selectRoomRadio��$��selected_rooms_radio��$
��Left=�$��10,5,0,5q�]� ��. $��0,0,0,36q�.+��� -   
 ��Name$
 selectFoorLabel��$	��Top=�$��select_floor_label���� -    ��Name$ FloorTypeListBox��$��Hidden=�#��� ��#��� ��$��	0,0,0,170q����� .R��� ���� *Name+�� -    ��Name$ groupboxParam��$��groupboxParam��#��� ��$��1q�$��55��$��0,0,0,50q�#��� ��$��Bottom=�$��73�� � IsSharedSizeScope . .���� $��2�� �� Orientation$ 
Horizontal=�$��	0,0,-12,0q�$��Bottom=�$��37��$
��Left=�$	��522��.+�]� ��.  $
��Left=�#��� ��$��Center=�$��45��$��0,-8,0,0q�.+��� -    ��Name$ paramSelector��$	��5,0q�{�. $	��180��$��22��$	��229��$��Center=�$
��Left=�$��20��$��Center=��� $��+��$��Bottom=�$
��Left=�$��45��$��Center=�$��0q�]� $��0,-8,0,0q�$	��231��$��45��$
��Left=�$��Bottom=�#��� ��.+��� -    ��Name$ Height_TextBox�� �� TextWrapping$
 Wrap=�$��0��$	��5,0q�{�. $
��Left=�$��Center=� �� 	UndoLimit$ 0��$��Center=�$	��100��$��20��$	��100��$��20��#��� ��#��� ���� $ 
Horizontal=�$��45��$��45��$��Bottom=�$
��Left=�$	��522��.+��� -    ��Name$ okButton��$��	Ok_Button�� �� 	IsDefault . $��25��$��10q�$��25��$��88��$��Center=�#��� ��#��� ��4  .System.Windows.Automation.AutomationProperties   	LabeledBy +   %UIFramework.PropertyGrid.PropertyGrid  �� -	   $ cancelButton��$��Cancel_Button�� �� IsCancel . $��Center=�$��Center=�$��10q�$��25��$��25��$��88��$��Center=�#��� ��#��� ��   �� -
   $ groupboxRoomSelect��$��GroupBox��$��83��$��	0,0,0,123q�$��Bottom=�#��� ��