﻿/* 
 * Copyright 2011 Felix Rüttiger
 * 
 * This file is part of VirtualBoxService.
 *
 * VirtualBoxService is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * VirtualBoxService is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with VirtualBoxService.  If not, see <http://www.gnu.org/licenses/>.
 * 
 **/

namespace VBoxWrapper
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public class VBox
	{
        public virtual IEnumerable<Machine> Machines {
            get;
            private set;
        }

		public virtual MachineBuilder MachineBuilder
		{
			get;
			set;
		}


        public VBox() {
            Machines = new List<Machine>();
        }


		public virtual void RefreshMachines()
		{
            Machines = MachineBuilder.buildMachineList().ToList();
		}

		public virtual void DisposeMachines()
		{
            foreach (var m in Machines) {
                m.Dispose();
            }
            Machines = new List<Machine>();
		}
	}
}

