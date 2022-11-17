using Domain.Interfaces;
using Entities.Entities;
using Infrastruture.Configuration;
using Infrastruture.Repository.Generics;
using Microsoft.EntityFrameworkCore;

namespace Infrastruture.Repository.Repositories;

public class RepositoryMessage : RepositoryGenerics<Message>, IMessage
{
    private readonly DbContextOptions<ContextBase> _OptionsBuilder;
    public RepositoryMessage()
    {
        _OptionsBuilder = new DbContextOptions<ContextBase>();
    }
}