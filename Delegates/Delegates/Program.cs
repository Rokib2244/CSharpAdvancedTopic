// See https://aka.ms/new-console-template for more information
using Delegates;

//Console.WriteLine("Hello, World!");
var processor = new PhotoProcessor();
var philters = new PhotoFilters();
PhotoProcessor.PhotoFilterHandler photoFilterHandler = philters.ApplyBrightness;
photoFilterHandler += RemoveRedEyeFilter;
//photoFilterHandler += philters.ApplyContrast;
processor.Process("Image",photoFilterHandler);

static void RemoveRedEyeFilter(Photo photo){
    Console.WriteLine("Apply RemoveRedEye");
}
