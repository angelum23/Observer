using Observer;
using Observer.Base;
using Observer.Domain;

Console.WriteLine("Hello, World!");


var offers = new Offers();
var bestOffer = new BestOffer();

var amazonBot = new AmazonBot();

amazonBot.RegisterObserver(offers);
amazonBot.RegisterObserver(bestOffer);

amazonBot.Scrapper();