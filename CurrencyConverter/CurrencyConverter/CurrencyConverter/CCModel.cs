/*
 * M226, CurrencyConverter
 * I.DA-D3A, 20/03/198
 * classe CCModel
 * constructeurs (désigné, de convenance)
 * propriétés
 * méthode Convert()
 * arrondi (RoundToEven) dans le setter de Source
 
 */
using System;

namespace CurrencyConverter {
  public class CCModel {

    // Constantes

    const double DEFAULT_RATE = 1.24;
    const double DEFAULT_SOURCE = 0.0;

    //Champs

    private double _rate;
    private double _source;



    // Propriétés

    public double Rate { get => _rate; set => _rate = value; }
    public double Source {
      get { return this._source; }
      set { this._source = Math.Round(value, MidpointRounding.ToEven); }
    }

    // Constructeur
    public CCModel() : this(DEFAULT_RATE) {
      // No code
    }

    public CCModel(double paramRate) : this(paramRate, DEFAULT_SOURCE) {
      // No code
    }

    public CCModel(double paramRate, double paramSource) {
      this.Rate = paramRate;
      this.Source = paramSource;
    }




    // Méthodes

    public double Convert(double pSource) {
      this.Source = pSource;
      return this.Rate * this.Source;

    }
  }
}
