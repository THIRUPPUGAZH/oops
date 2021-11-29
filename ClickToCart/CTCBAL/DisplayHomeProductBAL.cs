using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTCBE;
using CTCDAL;

namespace CTCBAL
{
    public class DisplayHomeProductBAL
    {
        public DisplayHomeProductRespone DisplayProduct()
        {
            HomeProductDAL GetALLProduct = new HomeProductDAL();
            DisplayHomeProductRespone response = null;
            try
            {
                response = GetALLProduct.DisplayProduct();
            }
            catch (Exception)
            {
                throw;
            }
            return response;
        }
        public DisplayHomeProductRespone DisplayCoolings()
        {
            HomeProductDAL GetALLProduct = new HomeProductDAL();
            DisplayHomeProductRespone response = null;
            try
            {
                response = GetALLProduct.DisplayCoolings();
            }
            catch (Exception)
            {
                throw;
            }
            return response;
        }
        public DisplayHomeProductRespone DisplayCrackers()
        {
            HomeProductDAL GetALLProduct = new HomeProductDAL();
            DisplayHomeProductRespone response = null;
            try
            {
                response = GetALLProduct.DisplayCrackers();
            }
            catch (Exception)
            {
                throw;
            }
            return response;
        }
        public DisplayHomeProductRespone DisplayMask()
        {
            HomeProductDAL GetALLProduct = new HomeProductDAL();
            DisplayHomeProductRespone response = null;
            try
            {
                response = GetALLProduct.DisplayMask();
            }
            catch (Exception)
            {
                throw;
            }
            return response;
        }

        public DisplayHomeProductRespone DisplayStationary()
        {
            HomeProductDAL GetALLProduct = new HomeProductDAL();
            DisplayHomeProductRespone response = null;
            try
            {
                response = GetALLProduct.DisplayStationary();
            }
            catch (Exception)
            {
                throw;
            }
            return response;
        }

        public DisplayHomeProductRespone GetFilter(int id)
        {
            HomeProductDAL GetALLProduct = new HomeProductDAL();
            DisplayHomeProductRespone response = null;
            try
            {
                response = GetALLProduct.GetFilter(id);
            }
            catch (Exception)
            {
                throw;
            }
            return response;
        }
        public DisplayHomeProductRespone cartshow(DisplayHomeProductRequest request)
        {
            HomeProductDAL GetALLProduct = new HomeProductDAL();
            DisplayHomeProductRespone response = null;
            try
            {
                response = GetALLProduct.cartshow(request);
            }
            catch (Exception)
            {
                throw;
            }
            return response;
        }
        public void updatecart(CartAdd request)
        {
            HomeProductDAL GetALLProduct = new HomeProductDAL();
            GetALLProduct.UpdateCart(request);
        }
        public void deleteCart(int id)
        {
            HomeProductDAL objcart = new HomeProductDAL();
            objcart.DeleteCart(id);
        }


    }
}
  
