![LOGO](https://cdn.rawgit.com/DevWizza/Movies/develop/README/Readme.png?raw=true) 
======================
  
Buy movie tickets in advance, find movie times, and more at "Movies". 
  
![COVER](https://cdn.rawgit.com/DevWizza/Movies/develop/README/Cover.png?raw=true)
 
## Table of content
 
- [Running](#Running)
- [Structure](#structure)
- [Libraries](#libraries)
- [Preview](#preview)

## Running

In order to get "Movies" running all you have to do is clone this in your local computer and open the solution. As long as you have Xamarin installed it will run.
 
## Structure
 
There is an Android, iOS and PCL solution.

![solution_screenshot](https://cdn.rawgit.com/DevWizza/Movies/develop/README/solution_screenshot.png?raw=true)

Most of the work was done in the PCL solution. Although I would like to point out that in order to have a working splash screen in Android I had to do some work in the local Android project itself but that didn't have anything to do with renderers which is awesome too! If you are curious about how I did it no worries! I will post a tutorial on [Intern Life](https://www.intern.life/) on how I did it.

## Libraries

Here are the libraries used that made this great learning resource possible.

1) For loosely coupled code and easy MVVM navigation [Prism](https://github.com/PrismLibrary/Prism)
2) For the bottom TabBar on Android: [BottomNavigationBarXF](https://github.com/thrive-now/BottomNavigationBarXF)
3) For the circled images: [ImageCircle](https://github.com/jamesmontemagno/ImageCirclePlugin)
4) For great performance when loading images: [FFImageLoading](https://github.com/luberda-molinet/FFImageLoading)
5) For cool INotifyPropertyChanged implementation: [Fody/PropertyChanged](https://github.com/Fody/PropertyChanged)

## Preview
  
This is what the app currently looks like. iOS on the left, Android on the right. ✌️
  
![preview](https://cdn.rawgit.com/DevWizza/Movies/develop/README/Preview.png?raw=true)
