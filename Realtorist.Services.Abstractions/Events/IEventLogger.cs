using System;
using System.Threading.Tasks;
using Realtorist.Models.Events;

namespace Realtorist.Services.Abstractions.Events
{
    /// <summary>
    /// Describes logger which operates with events
    /// </summary>
    public interface IEventLogger
    {
        /// <summary>
        /// Event for creating event
        /// </summary>
        event EventHandler<Event> EventCreated;

        /// <summary>
        /// Creates new event
        /// </summary>
        /// <param name="eventLevel">Event level</param>
        /// <param name="eventType">Event type</param>
        /// <param name="title">Event title</param>
        /// <param name="message">Event message</param>
        /// <returns>Event's id</returns>
        Task<Guid> CreateEventAsync(EventLevel eventLevel, string eventType, string title, string message);

        /// <summary>
        /// Creates new event for the exception
        /// </summary>
        /// <param name="eventType">Event type</param>
        /// <param name="title">Event title</param>
        /// <param name="message">Event message</param>
        /// <param name="exception">Exception</param>
        /// <returns>Event's id</returns>
        Task<Guid> CreateEventAsync(string eventType, string title, string message, Exception exception);
    }
}