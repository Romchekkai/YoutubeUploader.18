using CliWrap;
using YoutubeUploader._18;

var sender = new Sender();
var receivervideo = new ReceiverVideoDownload();
var receivervideoinfo = new ReceiverVideoInfo();    
var videodownload = new DownloadVideoCommand(receivervideo, "https://www.youtube.com/watch?v=0mh5d2a8wp0");
sender.SetCommand(videodownload); 
sender.Start();
var videoinfo = new VideoInfoCommand(receivervideoinfo, "https://www.youtube.com/watch?v=0mh5d2a8wp0");
sender.SetCommand(videoinfo);
sender.Start();
// Не работает пакет видео експлод, протестировать не удалось. в клиентском меню можно сделать конструкцию свитч с передачей вводимой ссылки с ютуб