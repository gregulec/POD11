   M S B A M L   `   `   `  ����@  <POD11, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:POD11POD11  5          POD11.Documentation   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      %localclr-namespace:POD11     5        N� Title$  Documentation��5	      $	��800��6   $	��600��6)    N� 
Background �	#FF323232.��5      � .+�5   
   �� -   5         ��Name$ label��5      $��Dokumentacja��6   $
��Left=�66   $��
264,55,0,0q�6Q   $	��Top=�6e   
�������$��36(�6�   $
��Bold"�6�   �� 5   
   -   5        $ label1��5      $����Kryptografia wizualna - w obazie wejściowycm w zależności od napotkanego pixela w dwóch udziałach są
ustawiane dwa pixele. Gdy pixel jest biały to w obu udziałach zestaw pixeli jest taki sam tj. biały i czarny lub
czarny i biały. Kiedy pixel jest czarny to dla drugiego udziału jest zestaw odwrotny. Odszyfrowanie polega na
założeniu na siebie dwóch udziałów. Gdy w obu udziałach na tej samej pozycji jest biały pixel to na obrazie
wyjściowym ustawiany jest biały pixel, w pozostałachy przypadkach ustawiany jest pixel koloru czarnego.

Dane wejściowe: obrazek w kolorach czarnym i białym
Dane wyjściowe: obrazek w kolorach czarnym i białym szerszy dwukrotnie od obrazka wejściowego
Format danych: obrazki powinny być z rozszerzeniem *.bmp
Rozmiar danych: brak ograniczeń
Ograniczenia: brak

Środowisko programistyczne: Visual Studio 2017

Autor: Agnieszka Gregulec��6    $
��Left=�6�  $��
10,174,0,0q�6  $	��Top=�6%  
�������$��16(�6P  $	��780��6^  $	��416��6j  5      5      