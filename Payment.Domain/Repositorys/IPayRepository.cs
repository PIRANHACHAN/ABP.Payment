using Payment.Domain.Pays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Domain.Repositorys
{
  /// <summary>
  /// 支付仓储（接口）
  /// Repository 接口都应该用异步操作
  /// </summary>
  public interface IPayRepository
  {
    /// <summary>
    /// 存储支付实体到数据库
    /// </summary>
    /// <param name="pay"></param>
    /// <returns></returns>
    public Task InsertAsync(Pay pay);
  }
}
