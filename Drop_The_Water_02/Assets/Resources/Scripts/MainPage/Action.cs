using System;

namespace Instruction
{
	public class Action : Instruction	//for move, jump, break
	{
		public Action (INSTRUCTION instruction)
		{
			if(instruction == INSTRUCTION.PLUS || instruction == INSTRUCTION.MINUS || instruction == INSTRUCTION.PLAY)
				this.instruction = instruction;
		}

		public Action(String instruction)
		{
			this.instruction = convert (instruction);
		}


		public override bool nextValid ()
		{
			return next is Direction;
		} 
	}
}