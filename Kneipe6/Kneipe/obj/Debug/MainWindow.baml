   M S B A M L   `   `   `  ����A  =Kneipe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:KneipeKneipe  5   	       Kneipe.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Kneipe     5   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �� -   5         ��Name$ Hintergrund��5	      $	��450��6"   $	��800��6/   ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6    � Offset$ 0Q�6-   � 5      $ 	#FF933BB4��6   $ 1Q�61   5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DgTisch1��5      $��	50,80,0,0q�6%   $��1��6u   5        5      -   5        $ DgTisch1Bestellung��5      $��
320,80,0,0q�63   $��1��6e      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Artikel��6%   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 66   �� 
 �� Path$
 Artikel�5        5      $ Preis��6%   	 64   �� *Preis+6Q   5      �� 5   
   -   5        $��Rechnung erstellen��5      $
��Left=�6.   $��32��6I   $��609,251,0,0q�6U   $	��Top=�6j   $	��113��6�   $��1��6�   �� 5   
   -   5         ��Name$
 StRg��5      $��1��6#   $
��Left=�63   $	��123��6N   $��
609,84,0,0q�6[   $	��Top=�6o   $	��113��6�   ��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $ Black��6#   $ 0Q�61   � 5      $ 	#FFF0D6D6��6#   $ 1Q�65   5      .+�5!      	� -   5         	�Name$ RbRg1��5!      $��
Rechnung 1��6)   $��10,40,10,10q�6>   	� 5"      -   5        $ RbRg2��5"      $��
Rechnung 2��6)   $��10,10,10,10q�6>   6U   5#      �� 5$   
   -	   5         ��Name$ BtSchließen��5$      $��
Schließen��6&   $��28��6:    �� Left$	 609��6F   
 �� Top$	 298��6X   $	��113��6i   6u   5%      5&      