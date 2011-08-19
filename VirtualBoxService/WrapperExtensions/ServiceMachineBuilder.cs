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

namespace VirtualBoxService.WrapperExtensions
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using VBoxWrapper;

	public class ServiceMachineBuilder : MachineBuilder
	{
        public override Machine buildMachine(IVirtualMachineProxy proxy) {
            DescriptionBasedInfoProvider infoProvider = new DescriptionBasedInfoProvider(proxy);
            ServiceAwareMachine m = new ServiceAwareMachine(infoProvider.GetMachineProxyDescriptionFilter());
            m.ServiceInfoProvider = infoProvider;
            return m;
        }
	}
}

