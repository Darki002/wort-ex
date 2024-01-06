using Microsoft.EntityFrameworkCore;
using WortEx.Infrastructure.Database.Context;
using WortEx.Infrastructure.Database.Models;

namespace WortEx.Infrastructure.Repositories;

public class MessageRepository(IDbContextFactory<MessageContext> contextFactory)
{
    public async Task SaveMessageAsync(MessageModel messageModel, CancellationToken cancellationToken)
    {
        await using var context = await contextFactory.CreateDbContextAsync(cancellationToken);
        await context.Messages.AddAsync(messageModel, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);
    }
    
    public async Task<List<MessageModel>> GetMessagesAsync(CancellationToken cancellationToken)
    {
        await using var context = await contextFactory.CreateDbContextAsync(cancellationToken);
        return await context.Messages.ToListAsync(cancellationToken);
    }
}