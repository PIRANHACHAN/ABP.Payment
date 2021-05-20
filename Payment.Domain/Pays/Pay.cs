using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Domain.Pays
{
  /// <summary>
  /// 支付模型（实体）
  /// </summary>
  public class Pay
  {
    // 支付编号
    public int Id { get; set; }

    // 支付类型
    public int PayType { get; set; }

    // 支付金额
    public decimal PayPrice { get; set; }

    // 支付下面的订单信息
    // 一对多，聚合关系
    // Pay 聚合根
    public List<PayOrder> PayOrders { get; set; }
  }
}
