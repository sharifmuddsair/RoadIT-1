﻿using System;
using Android.Gms.Maps.Model;
using Android.Util;

namespace RoadIT
{
	/**
	 * PartnerVehicle can be a truck or a finisher, depending on which vehicle the Ownvehicle class is.
	 * The OwnVehicle class contains a dynamic list of PartnerVehicles, from which it receives location updates to display on the map.
	 * PartnerVehicle mainly consists of parameter with getters and setters to modify these partners
	 */
	public class PartnerVehicle
	{
		private LatLng location;
		private string color;
		private int duration;
		private string id;
		private string locstring;
		private PolylineOptions polylineOptions;
		private bool nearest = false;
		private Random rnd = new Random();
		private string[] colorarray = new string[] { "red", "blue", "black", "purple" };

		//constructor gets location and an id(MAC adres)
		public PartnerVehicle(LatLng location, string id)
		{
			this.location = location;
			//random color from predefined array
			color = colorarray[rnd.Next(0, colorarray.Length)];
			this.id = id;
			//locstring is initialized
			locstring = location.Latitude.ToString().Replace(",", ".") + "," + location.Longitude.ToString().Replace(",", ".");
			polylineOptions = new PolylineOptions();
		}

		//setters and getters
		public void setNearest(bool nearest)
		{
			this.nearest = nearest;
		}

		public bool getNearest()
		{
			return nearest;
		}

		public string getcolor()
		{
			return color;
		}

		public void setcolor(string color)
		{
			this.color = color;
		}

		public string getid()
		{
			return id;
		}

		public void setDur(int duration)
		{
			this.duration = duration;
		}

		public int getDur()
		{
			return duration;
		}

		public string getlocstring()
		{
			return locstring;
		}

		public void setPolylineOptions(PolylineOptions poly)
		{
			polylineOptions = poly;
		}

		public PolylineOptions getPolylineOptions()
		{
			return polylineOptions;
		}

		public LatLng getLocation()
		{
			return location;
		}

		//locstring has to be changes as well when the location changes
		public void setLocation(LatLng location)
		{
			this.location = location;
			locstring = location.Latitude.ToString().Replace(",", ".") + "," + location.Longitude.ToString().Replace(",", ".");
		}

		//Display() function as a way to easily check the parameters when running the application
		public void display()
		{
			Log.Debug("disploc", locstring);
			Log.Debug("dispnearest", nearest.ToString());
			Log.Debug("dispcolor", color);
		}
	}
}

