using story_game_exercise.Context;
using story_game_exercise.Controllers.Commands;
using story_game_exercise.Helpers;
using story_game_exercise.Service;
using story_game_exercise.Service.Interface;
using story_game_exercise.Translators;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>();

// Services
builder.Services.AddTransient<IBookService, BookService>();
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IChapterService, ChapterService>();
builder.Services.AddTransient<IStoryService, StoryService>();


// Translators
builder.Services.AddSingleton<ITranslator<Book, VmBook>, BookTranslator>();
builder.Services.AddSingleton<ITranslator<User, VmUser>, UserTranslator>();
builder.Services.AddSingleton<ITranslator<Chapter, VmChapter>, ChapterTranslator>();
builder.Services.AddSingleton<ITranslator<Story, VmStory>, StoryTranslator>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

