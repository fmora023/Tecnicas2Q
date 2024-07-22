using ModelClase.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ControllerClase
{
    /// <summary>
    /// Singleton in charge of handling data.
    /// </summary>
    public class DataHandler
    {
        private DataHandler instance { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataHandler"/> class.
        /// </summary>
        private DataHandler() 
        {
            this.Personas = new List<IPersona>();
        }

        /// <summary>
        /// Gets or sets the personas.
        /// </summary>
        /// <value>
        /// The personas.
        /// </value>
        public List<IPersona> Personas { get; set; }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>
        /// The instance.
        /// </value>
        public DataHandler Instance
        {
            get
            {
                if (this.instance == null)
                {
                   this.instance = new DataHandler();
                }

                return this.instance;
            }
        }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <returns></returns>
        public static DataHandler GetInstance()
        {
            return new DataHandler();
        }
    }
}
