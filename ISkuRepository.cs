using System;
using System.Collections.Generic;
using System.Text;

namespace SKU_App
{
    public interface ISkuRepository
    {
        List<Sku> getSkuList();
    }
}
