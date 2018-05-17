/*
 * Created by SharpDevelop.
 * User: Guillermo
 * Date: 17/05/2018
 * Time: 10:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic; 
using NHibernate;
using Parcial.Entities;

namespace Parcial.Repository
{
	/// <summary>
	/// Description of BandejaEntradaRepositorio.
	/// </summary>
	public class BandejaEntradaRepositorio
	{
		ISession sesion;
		
		public BandejaEntradaRepositorio()
		{
		}
		
		
		public void setSession(ISession sesion){
			this.sesion = sesion;
		}
		
		public ISession getSessionFactory(){
			return sesion;
		}
	
	}
}
