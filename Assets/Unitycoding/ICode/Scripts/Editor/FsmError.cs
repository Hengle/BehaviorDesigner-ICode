﻿using UnityEngine;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using ICode;

namespace ICode.FSMEditor{
	[SerializeField]
	public class FsmError  {
		private FsmError.ErrorType type;
		public FsmError.ErrorType Type{
			get{
				return type;
			}
		}

		private FieldInfo fieldInfo;
		public FieldInfo FieldInfo{
			get{
				return fieldInfo;
			}
		}

		
		private StateMachine stateMachine;
		public StateMachine StateMachine{
			get{
				return stateMachine;
			}
		}

		private State state;
		public State State{
			get{
				return state;
			}
		}

		private ExecutableNode executableNode;
		public ExecutableNode ExecutableNode{
			get{
				return executableNode;
			}
		}


		private FsmVariable variable;
		public FsmVariable Variable{
			get{
				return variable;
			}
		}


		public FsmError(FsmError.ErrorType type,StateMachine stateMachine,State state,ExecutableNode executableNode,FsmVariable variable ,FieldInfo fieldInfo){
			this.type = type;
			this.variable = variable;
			this.fieldInfo = fieldInfo;
			this.stateMachine = stateMachine;
			this.state = state;
			this.executableNode = executableNode;
		}

		public bool SameAs(FsmError error){

			if (type != error.Type) {
				return false;			
			}

			if (variable != error.Variable) {
				return false;			
			}

			if (state != error.state) {
				return false;
			}

			return true;
		}

		public override string ToString ()
		{
			return string.Format ("[FsmError: Type={0}, FieldInfo={1}, StateMachine={2}, State={3}, ExecutableNode={4}, Variable={5}]", Type, FieldInfo, StateMachine, State, ExecutableNode, Variable);
		}

		public enum ErrorType{
			RequiredField,
			Name,
			Obsolete
		}
	}

}