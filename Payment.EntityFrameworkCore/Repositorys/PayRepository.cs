using Payment.Domain.Pays;
using Payment.Domain.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.EntityFrameworkCore.Repositorys
{
  /// <summary>
  /// 支付实体存储
  /// </summary>
  public class PayRepository : IPayRepository
  {
    public Task InsertAsync(Pay pay)
    {
      throw new NotImplementedException();
    }
  }
}
