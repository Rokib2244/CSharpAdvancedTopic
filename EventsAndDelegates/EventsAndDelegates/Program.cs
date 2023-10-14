// See https://aka.ms/new-console-template for more information
using EventsAndDelegates;


var video = new Video() { Title = "Video 1" };
var videoEncoder = new VideoEncoder();//publisher
var mailService = new MailService();//Subscriber
var messagesrvice = new MessageService();//Suibscriber

videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
videoEncoder.VideoEncoded += messagesrvice.OnVideoEncoded;
// after event, I mean after += we need to register handler for.. Here we are registering though "mailService.OnVideoEncoded".. NB: here "mailService.OnVideoEncoded" is not calling a function.. Actually it is a Reference/Pointer
//So it is clear that "videoEncoder.VideoEncoded" is a list of pointers to method

videoEncoder.Encode(video);
