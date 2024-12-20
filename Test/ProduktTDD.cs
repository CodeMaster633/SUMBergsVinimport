﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLogic.BLL;
using DTO.Model;
using Moq;
using NUnit;
namespace Test
{
	internal class ProduktTDD
	{

		private IProdukt _produktDTO;
		
		private LagerBLL _lagerBll;
		[SetUp]
		public void Setup()
		{
			_produktDTO = new ØlDTO();
			_lagerBll = new LagerBLL();
		}


		

		[Test]
		public virtual void OpretProduktForventetTest() 
		{
			//Arrange 






			//ACT
			_lagerBll.OpretProdukt(_produktDTO);
			IProdukt produktTDD = _lagerBll.GetProdukt(_produktDTO.Id);



			//Assert 
			Assert.That(produktTDD, Is.Not.Null);
		}
		

	}
}
