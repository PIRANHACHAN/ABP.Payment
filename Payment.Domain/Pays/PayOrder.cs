using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Domain.Pays
{
  /// <summary>
  /// 支付订单信息（模型）
  /// </summary>
  public class PayOrder
  {
    // 支付id
    public int Id { get; set; }

    // 订单id
    public int OrderId { get; set; }

    // 订单数量
    public int OrderCount { get; set; }
  }
}
