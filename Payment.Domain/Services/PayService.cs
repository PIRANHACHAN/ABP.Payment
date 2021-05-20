using Payment.Domain.Pays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Domain.Services
{
  public class PayService
  {
    public void Update(Pay pay)
    {
      pay.PayType = 2;
    }
  }
}
