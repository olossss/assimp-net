﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Assimp.Sample {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            SimpleOpenGLSample sample = new SimpleOpenGLSample();
            sample.Run(30.0, 0.0);
        }
    }
}