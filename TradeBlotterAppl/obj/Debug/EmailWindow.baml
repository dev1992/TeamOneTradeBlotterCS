   M S B A M L   `   `   `  ����K  GTradeBlotterAppl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:TradeBlotterApplTradeBlotterAppl  5   	   "    TradeBlotterAppl.EmailWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:TradeBlotterAppl     5   	     � Title$  EmailWindow��5   	   $	��600��6   $
��1200��5	   	    � Left$ 80��5
   	   
 � Top$	 100��5   	   .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $��* �6    .+�5      ��  �� Orientation$ 
Horizontal=�6   $��1��62   $��448,485,-82,43q�6?   .+�5      �� $��0��6   $��5q�6%   ��5      �� 5       �� Path$ CurrentPage�6"    �� StringFormat$ Current Page: {0}��5   [   5      5      �� 5      -   5        $��Previous��5      $��2q�6F   �� 5      -   5        $
��Next��5      $��2q�6>    J� RenderTransformOrigin$ 2.065,0.453&�6I   $��52��6m   5      &   System.Windows.Controls.DataGrid  5       -   5        $��messages��5       $��1��6?   $��41,89,303,90q�6L   ��6'   ��    Columns 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn	   Header$	 creator��6)   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 6:   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� *CreatorName+  5#      $	 trader��6)   $
 * 69    6C   �� *traders_traderId+  5$      $	 receiver��6)   $
 * 6;    6E   �� *
receiverId+  5%      $	 mailBody��6)   $
 * 6;    6E   �� *
mailBody+5'      �� 5(      -   5         ��Name$ 	txtMailID��5(      $
��Left=�6)   $��45��6D   $��984,161,0,0q�6P   $��1��6e    �� TextWrapping$
 Wrap=�6r   $�� ��6�   $	��Top=�6�   $	��172��6�   �� 5)      -   5        $ txtEmailBody��5)      $
��Left=�6,   $��91��6G   $��984,271,0,0q�6S   $��1��6h   $
 Wrap=�6u   $�� ��6�   $	��Top=�6�   $	��172��6�   �� 5*      -   5         ��Name$ button��5*      $
��Send��6%   $
��Left=�64   $��1030,414,0,0q�6O   $��1��6e   $	��Top=�6r   $	��100��6�   $��40��6�   6�   �� 5+      -   5         ��Name$ label��5+      $��
Your Mails��6#   $
��Left=�68   $��
125,54,0,0q�6S   $��1��6g   $	��Top=�6t   $	��164��6�   $��24��6�   �� 5,      -   5        $ label1��5,      $��Enter user name��6$   $
��Left=�6>   $��984,121,0,0q�6Y   $��1��6n   $	��Top=�6{   $	��104��6�   $��31��6�   �� 5-      -	   5        $ label2��5-      $��enter the mail body��6$   $
��Left=�6B   $��984,234,0,0q�6]   $��1��6r   $	��Top=�6   $	��104��6�   5.      54      55      