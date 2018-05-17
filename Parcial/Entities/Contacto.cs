/*
 * 
 * Created by SharpDevelop.
 * User: Guillermo
 * Date: 17/05/2018
 * Time: 9:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Parcial.Entities
{
	/// <summary>
	/// Description of Contacto.
	/// </summary>
	public class Contacto
	{
		private int codigo;
		private string nombre;
		private int edad;
		private IList<Mail> mails;
		
		public Contacto()
		{
			mails = new IList<Mail>();
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
		public virtual string Nombre
		{
			get
			{
				return nombre;
			}
			set
			{
				nombre = value;
			}
		}
		public virtual int Edad
		{
			get
			{
				return edad;
			}
			set
			{
				edad = value;
			}
		}
		
		public virtual IList<Mail> Mails
		{
			get
			{
				return mails;
			}
			set
			{
				mails = value;
			}
		}
		
		
	
	}
}
