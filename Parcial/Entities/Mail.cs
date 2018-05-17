/*
 * Created by SharpDevelop.
 * User: Guillermo
 * Date: 17/05/2018
 * Time: 9:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Parcial.Entities
{
	
	public class Mail
	{
		
		private string remitente;
		private string direccion;
		private Contacto contacto;
		private int codigo;
		private BandejaEntrada bandeja;
		
		public Mail()
		{
	
		}
		
		public virtual int Codigo
		{
			get
			{
				return codigo;
			}
			set 
			{
				codigo = value;
			}
		}
		
		public virtual string Remitente
		{
			get 
			{
				return remitente;
			}
			set
			{
				remitente = value;
			}
		}
		
		public virtual string Direccion
		{
			get
			{
				return direccion;
			}
			
			set
			{
				direccion = value;
			}
		}
		
		public Contacto Contacto
		{
			get
			{
				return contacto;
			}
			set
			{
				contacto = value;
			}
		}
		
		public BandejaEntrada Bandeja
		{
			get
			{
				return bandeja;
			}
			set
			{
				bandeja = value;
			}
		}
	}
}
