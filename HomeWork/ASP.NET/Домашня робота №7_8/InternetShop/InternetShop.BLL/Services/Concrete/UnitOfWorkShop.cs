
using InternetShop.BLL.Models.UIModels;
using InternetShop.BLL.Services.Abstract;
using System;
using System.Threading.Tasks;
using System.Transactions;

namespace InternetShop.BLL.Services.Concrete
{
    public class UnitOfWorkShop : IUnitOfWork
    {
        public IEntityService<GoodVM> GoodsRepo { get; }
        public IEntityService<CategoryVM> CatsRepo { get; }
        public IEntityService<ManufacturerVM> MansRepo { get; }
        public IEntityService<PhotoVM> PhotosRepo { get; }

        public UnitOfWorkShop(IEntityService<GoodVM> goodsRepo, IEntityService<CategoryVM> catsRepo, IEntityService<ManufacturerVM> mansRepo, IEntityService<PhotoVM> photosRepo)
        {
            this.GoodsRepo = goodsRepo;
            this.CatsRepo = catsRepo;
            this.MansRepo = mansRepo;
            this.PhotosRepo = photosRepo;
        }

        public async Task SaveAsync()
        {
            try
            {
                await GoodsRepo.SaveAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void Save()
        {
            GoodsRepo.Save();
        }

        
        private bool _disposed = false;

        public virtual void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
                this._disposed = true;
        }
    }
}
