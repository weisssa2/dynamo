﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Helper.External.Model
{
    // <summary>
    // This class hold the properties of a User
    // </summary>

    public class User
    {

        public String _fName { get; set; }
        public String _lName { get; set; }
        public String _gender { get; set; }
        public int _age { get; set; }
        public String _type { get; set; }
        public String _focus { get; set; }
        public int _currentweight { get; set; }
        public int _targetweight { get; set; }
        public int _height { get; set; }
        public String _difficulty { get; set; }

        // Empty Constructor
        public User()
        {
            this._fName = _fName;
            this._lName = _lName;
            this._gender = _gender;
            this._type = _type;
            this._focus = _focus;
            this._currentweight = _currentweight;
            this._targetweight = _targetweight;
            this._height = _height;
            this._difficulty = _difficulty;
        }

        public double BMI
        {
            get { return Math.Round(703 * (_currentweight / Math.Pow(_height, 2))); }
        }
        public double getDifferencce
        {
            get { return Math.Abs( _currentweight - _targetweight); }
        }
    }
}