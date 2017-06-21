﻿using System.ServiceModel;

namespace Dropshot.WebServices {
	[ServiceContract]
	public interface IApplicationWebServiceContract {
		[OperationContract]
		byte[] AuthenticateApplication(byte[] data);

		[OperationContract]
		byte[] GetConfigurationData(byte[] data);

		[OperationContract]
		byte[] GetMaps(byte[] data);

		[OperationContract]
		byte[] SetMatchScore(byte[] data);
	}
}