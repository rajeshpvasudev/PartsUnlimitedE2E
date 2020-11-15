using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsUnlimited.Models
{
	// my third cahnge
	public interface ILineItem
	{
		int Count { get; }

		Product Product { get; }
	}
}
