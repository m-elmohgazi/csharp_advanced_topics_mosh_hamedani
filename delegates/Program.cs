using delegates;



//PhotoProcessor processor= new PhotoProcessor();
//processor.Process("photo.jpg");
//--------
PhotoProcessor processor = new PhotoProcessor();
var photoFilters = new PhotoFilters();
PhotoProcessor.PhotoFilterHandler filterHandler = photoFilters.ApplyBrightness;

Remove test = new Remove();
filterHandler += test.RemoveRedEyeFilter;
filterHandler += photoFilters.ApplyContrast;
filterHandler -= test.RemoveRedEyeFilter;

processor.Process("photo.jpg",filterHandler);
