using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Realtorist.Models.Media;
using Realtorist.Models.Pagination;

namespace Realtorist.Services.Abstractions.Upload
{
    /// <summary>
    /// Provides operations for file uploads
    /// </summary>
    public interface IUploadService 
    {
        /// <summary>
        /// Uploads file
        /// </summary>
        /// <param name="file">File to upload</param>
        /// <param name="originalName">Original file name</param>
        /// <returns>Media descriptor</returns>
        Task<MediaFile> UploadFileAsync(Stream file, string originalName);

        /// <summary>
        /// Gets files
        /// </summary>
        /// <param name="request">Pagination request</param>
        /// <returns>File uploads</returns>
        Task<PaginationResult<MediaFile>> GetFilesAsync(PaginationRequest request);

        /// <summary>
        /// Gets all files
        /// </summary>
        /// <returns>All file uploads</returns>
        Task<IEnumerable<MediaFile>> GetFilesAsync();

        /// <summary>
        /// Deletes file by id
        /// </summary>
        /// <param name="id">Id of the file</param>
        Task DeleteFileAsync(string id);
    }
}