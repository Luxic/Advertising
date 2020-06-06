using System;
using System.Collections.Generic;
using System.Data.Services;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DataService
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
	[ServiceContract]
	public interface IService1 : DataService<>
	{
		[OperationContract]
		void DoWork();
	}
}
