﻿using CurricullumVitae.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace CurricullumVitae.Data.Access
{
    public interface IExtraRepository : IRepository<ExtraVM>
    {

    }
    public class ExtraRepository : Repository<ExtraVM>, IExtraRepository
    {
        public ExtraRepository(ApplicationDbContext ctx, ILogger<ExtraRepository> logger) : base(ctx, logger)
        {

        }

        public override async Task<ExtraVM> Add(ExtraVM item, ClaimsPrincipal user)
        {
            if (item == null)
                return null;
            if (string.IsNullOrEmpty(item.Title))
                return null;
            if (item.Document == null)
                return null;
            try
            {
                var extra = new ExtraVM
                {
                    Title = item.Title,
                    Document = item.Document,
                    DocumentId = item.DocumentId,
                    Content = item.Content,

                };
                _ctx.Extras.Add(extra);
                await _ctx.SaveChangesAsync();
                return extra;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }

        public override async Task<IEnumerable<ExtraVM>> Get(bool asNoTracking = false)
        {
            try
            {
                var rv = new List<ExtraVM>();
                var sourceCollection = await _ctx.Extras.ToListAsync();
                foreach (var source in sourceCollection)
                {
                    var vm = new ExtraVM
                    {
                        Title = source.Title,
                        Document = source.Document,
                        DocumentId = source.DocumentId,
                        Content = source.Content,

                    };
                    rv.Add(vm);
                }
                return rv;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }

        public override async Task<ExtraVM> GetById(int id, bool asNoTracking = false)
        {
            try
            {
                var sourceCollection = _ctx.Extras.AsQueryable();
                if (asNoTracking)
                {
                    sourceCollection = sourceCollection.AsNoTracking();
                }
                var extra = await sourceCollection.FirstOrDefaultAsync(x => x.Id == id);
                if (extra != null)
                {
                    return null;
                    throw new ArgumentNullException(nameof(extra));
                }
                var rv = new ExtraVM()
                {
                    Title = extra.Title,
                    Document = extra.Document,
                    DocumentId = extra.DocumentId,
                    Content = extra.Content,

                };
                return rv;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }

        public override Task<bool> Remove(ExtraVM item, ClaimsPrincipal user)
        {
            throw new NotImplementedException();
        }

        public override async Task RemoveById(int id, ClaimsPrincipal user)
        {
            try
            {
                var extra = await _ctx.Extras.FirstOrDefaultAsync(x => x.Id == id);
                if (extra == null)
                    throw new ArgumentNullException(nameof(extra));
                _ctx.Extras.Remove(extra);
                await _ctx.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }

        public override async Task<bool> Update(int id, ExtraVM newData, ClaimsPrincipal user)
        {
            try
            {
                var extra = await _ctx.Extras.FirstOrDefaultAsync(x=>x.Id== id);
                if (extra == null)
                    return false;
                if (!string.IsNullOrEmpty(newData.Title))
                {
                    extra.Title = newData.Title;
                }
                if(!string.IsNullOrEmpty(newData.Content))
                {
                    extra.Content = newData.Content;
                }
                await _ctx.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }
    }
}
