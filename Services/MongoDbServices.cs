using MongoDb.Models;
using MongoDB.Driver;  
using MongoDB.Bson;
using Microsoft.Extensions.Options;

namespace MongoDb.Services;


public class MongoDbService{

    private readonly IMongoCollection<Tasks> _taskCollection;
} 