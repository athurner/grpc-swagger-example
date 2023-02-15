using GrpcSwaggerExample;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGrpcSwagger();
builder.Services.AddSwaggerGen();
builder.Services.AddGrpc().AddJsonTranscoding();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseRouting();
app.MapGrpcService<Service>();

app.Run();