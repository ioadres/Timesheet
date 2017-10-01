using System;
using System.Linq;
using System.Reflection;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using Tokiota.ViewModels;

namespace Tokiota.Infrastructure
{
	public class InstanceResolver
	{
		public InstanceResolver()
		{			
		}

		public object Resolve(string viewModelName)
		{
			var vmtype = this.GetType()
				.GetTypeInfo()
				.Assembly
				.DefinedTypes
				.FirstOrDefault(t => t.Name.Equals(viewModelName))
				.AsType();

            return SimpleIoc.Default.GetInstance(vmtype);
		}
	}
}
