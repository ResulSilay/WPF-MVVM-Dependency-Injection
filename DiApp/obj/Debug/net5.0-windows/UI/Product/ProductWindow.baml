   M S B A M L   `   `   `  ����@  <DiApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:DiApp.UI.ProductDiApp.UI.Product  5      $    DiApp.UI.Product.ProductWindow   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      0modelclr-namespace:DiApp.UI.Product     5        � Title$  ProductWindow��5      $	��800��5	      $	��450��5
       � WindowStartupLocation$ CenterScreen=�5       � 	Resources 5         ProductDataTemplate �� DataType   DiApp.UI.Product.Product �� Orientation �� Path �� Mode  ButtonListBoxStyle �� ElementName �� Opacity	 �� Color��%�  &	        7  �� 5   
   "  63   .R�5      �� $ Vertical=�6   .+�5      �� $ 
Horizontal=�6   .+�5      �� $	��100��5      $��Center=�5      $��Stretch=�5      ��5      �� $ 	ProductId�$ OneWay=��� 5      $
��auto��5      $��Center=�5      $��Stretch=�5      ��5      �� $ Barcode�$ OneWay=��� 5      $
��auto��5      $��Center=�5       $��Stretch=�5!      ��5"      �� $
 Name�$ OneWay=��� 5$      $
��auto��5%      $��Center=�5&      $��Stretch=�5'      ��5(      �� $ Description�$ OneWay=��� 5*      $
��auto��5+      $��Center=�5,      $��Stretch=�5-      ��5.      �� $ Price�$ OneWay=��� 50      $
��auto��51      $��Center=�52      $��Stretch=�53      ��54      �� $ Source�$ OneWay=��� 56      $��Right=�57      $��Center=�58      $ 
Horizontal=�59      .+�5:      �� $
��auto��5;      $��Center=�5<      $��Detay��5?      8��  ��5=      �� $ ProductListBox��$( "DataContext.OnProductDetailCommand���5>      �� 5@      5A      5B      �� 5C      ��5D      �� 5E      $
 0.03Q�6*   $	 	#FF0F0F0F��69   5G      5H      5I      5J      .��5L      � .+�5N   
   �� -   5        $��ProductListBox��5O      $��Stretch=�5P      
������ $��0q�5R      #��[  5S      $��Hidden=�5U      ��5T      �� *
Products+5U      5W      5X      