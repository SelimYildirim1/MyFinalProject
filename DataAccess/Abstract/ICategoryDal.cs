using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;


namespace DataAccess.Abstract
{
   public interface ICategoryDal:IEntityRepository<Category>
    {
        //Interface metotları default u public tir yazmaya gerek olmaz 
    }
}
