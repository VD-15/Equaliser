using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equaliser.Engine
{
	class Collider
	{
		private Transform transform {
			get { return transform; }
			set { transform = value; }
		}

		public bool Intersects(Collider collider) {
			return false;
		}

		public bool Intersects(Collider[] colliders)
		{
			foreach(Collider c in colliders)
				if(Intersects(c))
					return true;
			return false;
		}

	}
}
