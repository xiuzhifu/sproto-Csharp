// Generated by sprotodump. DO NOT EDIT!
// source: ../gen_example/TestAll.sproto

using System;
using Sproto;
using System.Collections.Generic;

namespace TestAll{ 
	public class Foobar : SprotoTypeBase {
		private static int max_field_count = 15;
		
		public class Nest : SprotoTypeBase {
			private static int max_field_count = 6;
			
			
			private string _a; // tag 1
			public string a {
				get { return _a; }
				set { base.has_field.set_field (0, true); _a = value; }
			}

			private bool _b; // tag 3
			public bool b {
				get { return _b; }
				set { base.has_field.set_field (1, true); _b = value; }
			}

			private Int64 _c; // tag 5
			public Int64 c {
				get { return _c; }
				set { base.has_field.set_field (2, true); _c = value; }
			}

			public Nest () : base(max_field_count) {}

			public override void init (byte[] buffer) {
				base.init (buffer);
				this.decode (buffer);
			}

			public Nest (byte[] buffer) : base(max_field_count, buffer) {
				this.decode (buffer);
			}

			protected override void decode (byte[] buffer) {
				int tag = -1;
				while (-1 != (tag = base.deserialize.read_tag ())) {
					switch (tag) {
					case 1:
						this.a = base.deserialize.read_string ();
						break;
					case 3:
						this.b = base.deserialize.read_boolean ();
						break;
					case 5:
						this.c = base.deserialize.read_integer ();
						break;
					default:
						base.deserialize.read_unknow_data ();
						break;
					}
				}
			}

			public override byte[] encode () {
				if (base.has_field.has_field (0)) {
					base.serialize.write_string (this.a, 1);
				}

				if (base.has_field.has_field (1)) {
					base.serialize.write_boolean (this.b, 3);
				}

				if (base.has_field.has_field (2)) {
					base.serialize.write_integer (this.c, 5);
				}

				byte[] buffer = base.serialize.encode ();
				base.serialize.clear ();

				return buffer;
			}
		}


		
		private string _a; // tag 0
		public string a {
			get { return _a; }
			set { base.has_field.set_field (0, true); _a = value; }
		}

		private Int64 _b; // tag 1
		public Int64 b {
			get { return _b; }
			set { base.has_field.set_field (1, true); _b = value; }
		}

		private bool _c; // tag 2
		public bool c {
			get { return _c; }
			set { base.has_field.set_field (2, true); _c = value; }
		}

		private Foobar.Nest _d; // tag 3
		public Foobar.Nest d {
			get { return _d; }
			set { base.has_field.set_field (3, true); _d = value; }
		}

		private List<string> _e; // tag 4
		public List<string> e {
			get { return _e; }
			set { base.has_field.set_field (4, true); _e = value; }
		}

		private List<Int64> _f; // tag 5
		public List<Int64> f {
			get { return _f; }
			set { base.has_field.set_field (5, true); _f = value; }
		}

		private List<bool> _g; // tag 6
		public List<bool> g {
			get { return _g; }
			set { base.has_field.set_field (6, true); _g = value; }
		}

		private Foobar _h; // tag 7
		public Foobar h {
			get { return _h; }
			set { base.has_field.set_field (7, true); _h = value; }
		}

		public Foobar () : base(max_field_count) {}

		public override void init (byte[] buffer) {
			base.init (buffer);
			this.decode (buffer);
		}

		public Foobar (byte[] buffer) : base(max_field_count, buffer) {
			this.decode (buffer);
		}

		protected override void decode (byte[] buffer) {
			int tag = -1;
			while (-1 != (tag = base.deserialize.read_tag ())) {
				switch (tag) {
				case 0:
					this.a = base.deserialize.read_string ();
					break;
				case 1:
					this.b = base.deserialize.read_integer ();
					break;
				case 2:
					this.c = base.deserialize.read_boolean ();
					break;
				case 3:
					this.d = base.deserialize.read_obj<Foobar.Nest> ();
					break;
				case 4:
					this.e = base.deserialize.read_string_list ();
					break;
				case 5:
					this.f = base.deserialize.read_integer_list ();
					break;
				case 6:
					this.g = base.deserialize.read_boolean_list ();
					break;
				case 7:
					this.h = base.deserialize.read_obj<Foobar> ();
					break;
				default:
					base.deserialize.read_unknow_data ();
					break;
				}
			}
		}

		public override byte[] encode () {
			if (base.has_field.has_field (0)) {
				base.serialize.write_string (this.a, 0);
			}

			if (base.has_field.has_field (1)) {
				base.serialize.write_integer (this.b, 1);
			}

			if (base.has_field.has_field (2)) {
				base.serialize.write_boolean (this.c, 2);
			}

			if (base.has_field.has_field (3)) {
				base.serialize.write_obj (this.d, 3);
			}

			if (base.has_field.has_field (4)) {
				base.serialize.write_string (this.e, 4);
			}

			if (base.has_field.has_field (5)) {
				base.serialize.write_integer (this.f, 5);
			}

			if (base.has_field.has_field (6)) {
				base.serialize.write_boolean (this.g, 6);
			}

			if (base.has_field.has_field (7)) {
				base.serialize.write_obj (this.h, 7);
			}

			byte[] buffer = base.serialize.encode ();
			base.serialize.clear ();

			return buffer;
		}
	}


}