   M S B A M L   `   `   `  ����d  `Microsoft.Maps.MapControl.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35tRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPFMicrosoft.Maps.MapControl.WPF  5       Medical center-Lifeline%   Medical_center_Lifeline.Aboutas   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      a ]Syncfusion.SfMaps.WPF, Version=20.1460.0.51, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.Shared.Wpf, Version=20.1460.0.51, Culture=neutral, PublicKeyToken=3d67ed1f87d44c894
syncfusion!http://schemas.syncfusion.com/wpf   5      \mRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPF   5      $	��823��5
      $
��1013��6     N� Title$  Aboutas��5      .��5      � 
������� � RowDefinitions 5   
   �� 5      $��69 �6   �� 5      $��240.8 �6   �� 5      $	��436 �6   .+�5   
   ��    Textgrey#��[  6   $��Center=�66   $
��Wrap=�6S   $7��1Ваше здоровье - наша забота��6g   $��Center=�6�   $��36(�6�   $	��496��6�   $��0��6�   $��43��6�   �� 5   
     Text_for_registration#��[ 6   $
��Left=�6C   $��79,72.4,0,0q�6^   $��1��6s   $
��Wrap=�6�   $	��Top=�6�   $	��482��6�   $��18(�6�   $	��176��6�   $��2��6�   �� 6�   $���«Lifeline» – крупнейший негосударственный многопрофильный медицинский центр Беларуси. С момента основания в 2022 году «��6�   �� 6j  $�Lifeline��6n  �� 6�  $���» успешно сохраняет свои лидирующие позиции на рынке медуслуг страны благодаря внедрению в практику самых передовых методов диагностики и лечения, внимательному, индивидуальному подходу к каждому пациенту и высокому уровню сервиса.��6�  6v  �� 5   
   $��692,10.4,75.8,10.2q�6   $��/image/hospital.png��6,   $��1��6I   �� 5   
   $	��291��6   $��52��6   $ ��/image/Plugin icon - 1.png��6(   $
��Fill=�6L   $��1��6[   $��0��6h   $
��Left=�6x   $��0,0.4,0,189.2q�6�   � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      $	��289 �6#   �� 5      $
��724* �6#   5      '   !Microsoft.Maps.MapControl.WPF.Map  5    
   +   %Microsoft.Maps.MapControl.WPF.MapCore   CredentialsProviderT   NMicrosoft.Maps.MapControl.WPF.Design.ApplicationIdCredentialsProviderConverter$F @AttsGkqIHCOIEA11KtQZDphl5bi8lppin64jeg-ZOOhiS4cdHA_EXJwHSbyZi4Xo 6      Mode;   5Microsoft.Maps.MapControl.WPF.Design.MapModeConverter$
 Road 6g   $��2��6s      	ZoomLevel$ 16Q�6�      Center<   6Microsoft.Maps.MapControl.WPF.Design.LocationConverter$ 53.855152, 27.560394 6�   $��293,175.8,306.8,-45q�6�      Children. 5!      �� ,   &Microsoft.Maps.MapControl.WPF.MapLayer   Position$ 53.855152, 27.560394 5"   	   	   PositionOriginB   <Microsoft.Maps.MapControl.WPF.Design.PositionOriginConverter$	 BottomCenter 5#   	   $��30��62   $��30��6=   .+�5$      �� $��/image/pin.png��6   $��30��60   
 J� RenderTransformOrigin$
 0.5,0.5&�6<   $��30��6\   5%      5&      �� 5'   
   $��0,6.8,739.8,376q�6   $��2��6)   $��/image/line.png��66   $
��Fill=�6O   �� 5(   
   $��740,241.4,-0.2,371q�6   $��1��6,   $��/image/line.png��69   $
��Fill=�6R   $��2��6a   �� 5)   
     	Textblack#��[ 6   $��Center=�67   $
��Wrap=�6T   $/��)Контактная Информация��6h   $��318,21.8,306.8,377q�6�   $��2��6�   $	��388��6�   �� 5*   
   #��[  6   $
��Left=�66   $
��Wrap=�6Q   $!��Тел: +375(33)-383-41-14 ��6e   $	��Top=�6�   $��59,88.8,0,0q�6�   $��2��6�   $��32(�6�   �� 5+   
   #��[  6   $��Right=�66   $
��Wrap=�6R   $?��9Адрес:г.Минск, ул.Маяковского 21 ��6f   $	��Top=�6�   $��0,88.8,21.8,0q�6�   $��2��6�   $��32(�6�   $	��481��6�   5-      5.      