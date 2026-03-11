using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Robot_Hazard_Analyzer
{
	public class RobotSafetyException : Exception
	{
		public RobotSafetyException (string message) : base(message)
		{
			
		}
	}

	internal class UserDefinedClass
    {
		public double CalculateHazardRisk(double armPrecision, int workerDensity, string machineryState)
		{
			if(armPrecision < 0.0 || armPrecision > 1.0)
			{
				throw new RobotSafetyException("Error: Arm precision must be between 0.0 and 1.0");
			}

			if(workerDensity < 1 || workerDensity > 20)
			{
				throw new RobotSafetyException("Error: Worker density must be 1-20");
			}
			
			if(machineryState != "Worn" && machineryState != "Faulty" && machineryState != "Critical")
			{
				throw new RobotSafetyException("Error: Unsupported machinery state");
			}

			double machineRiskFactor = 0;

			if(machineryState == "Worn")
			{
				machineRiskFactor = 1.3;
			}
			
			if(machineryState == "Faulty")
			{
				machineRiskFactor = 2.0;
			}

			if(machineryState == "Critical")
			{
				machineRiskFactor = 3.0;
			}

			double HazardRisk = ((1.0 - armPrecision) * 15.0) + (workerDensity * machineRiskFactor);
			return HazardRisk;
		}

	}
}
