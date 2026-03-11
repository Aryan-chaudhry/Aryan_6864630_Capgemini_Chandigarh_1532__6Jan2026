using System;
using System.Collections.Generic;

namespace MeetingApp
{
	public class Meeting<TParticipant, TAgenda>
	{
		public enum MeetingType
		{
			online,
			offline,
			Hybrid
		}

		public string Title { get; set; }
		public DateTime Date { get; set; }

		public string Meeting_Type { get; set; }

		public List<TParticipant> Participants { get; set; }
		public List<TAgenda> AgendaItems { get; set; }

		public Meeting(string title, DateTime date)
		{
			Title = title;
			Date = date;
			Participants = new List<TParticipant>();
			AgendaItems = new List<TAgenda>();
		}

		public void AddParticipant(TParticipant participant)
		{
			Participants.Add(participant);
		}

		public void AddAgendaItem(TAgenda agenda)
		{
			AgendaItems.Add(agenda);
		}

		public void meetingType()
		{
			Console.WriteLine("Mode of Meeting : \n 1. Online \n 2. Offline \n 3. Hybrid");
			int id = Convert.ToInt32(Console.ReadLine());

			switch (id)
			{
				case 1: Meeting_Type = MeetingType.online.ToString();
					Console.Write("Meeting scheduled online successfully \n");
					break;
				case 2: Meeting_Type = MeetingType.offline.ToString();
					Console.Write("Meeting scheduled offline successfully \n");
					break;
				case 3: Meeting_Type = MeetingType.Hybrid.ToString();
					Console.Write("Meeting scheduled hybrid successfully \n");
					break;
				default: Console.Write("You enter wrong choice");
					break;
			}
			
		}

		public void DisplayMeetingDetails()
		{
			Console.WriteLine($"Meeting: {Title}");
			Console.WriteLine($"Date: {Date}");
			Console.WriteLine("\nType:" + Meeting_Type);

			Console.WriteLine("\nParticipants:");
			foreach (var p in Participants)
				Console.WriteLine(p);


			Console.WriteLine("\nAgenda:");
			foreach (var a in AgendaItems)
				Console.WriteLine(a);

		}
	}
}
