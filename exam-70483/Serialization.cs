using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace exam_70483
{
	public enum Compass
	{
		North,
		South,
		East,
		West
	}

	[DataContract]
	public class Location
	{
		[DataMember]
		public string Label { get; set; }
		[DataMember]
		public Compass Direction { get; set; }
	}


	class Serialization
	{
		public static string WcfJsonSerializedLocation()
		{
			var location = new Location() { Label = "label", Direction = Compass.North };

			var jsonSerializer = new DataContractJsonSerializer(typeof(Location));

			using (var stream = new MemoryStream())
			{
				jsonSerializer.WriteObject(stream, location);

				stream.Position = 0;
				var streamReader = new StreamReader(stream);

				return streamReader.ReadToEnd();
			}

		}
	}
}
