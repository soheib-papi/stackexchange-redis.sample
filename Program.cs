
using StackExchange.Redis;

ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("localhost");

IDatabase db = redis.GetDatabase(0);

Console.WriteLine(db.StringGet("user:1").ToString());


string value = "abcdefg";
db.StringSet("mykey", value);

Console.ReadLine();