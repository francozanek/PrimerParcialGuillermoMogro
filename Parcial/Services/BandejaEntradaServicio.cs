/*
 * Created by SharpDevelop.
 * User: Guillermo
 * Date: 17/05/2018
 * Time: 10:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using veterinaria.Repository;
using veterinaria.Entities;
using NHibernate;

namespace Parcial.Services
{
	
	public class BandejaEntradaServicio
	{
		
		private BandejaEntradaServicio Repo;
		
		public BandejaEntradaServicio()
		{
			repo = new ClienteRepository();
		}
		
		public void setSession(ISession sesion){
			repo.setSession(sesion);
		}
		
	}
}
