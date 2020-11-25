// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="OmrResponse.cs">
//  Copyright (c) 2020 Aspose.Omr for Cloud
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Aspose.Omr.Cloud.Sdk.Model 
{
  using System.Text;

  /// <summary>
  /// Represents information about response after OMR.
  /// </summary>  
  public class OmrResponse 
  {                       
        /// <summary>
        /// Integer field that indicates whether any critical errors occured during task execution
        /// </summary>  
        public int? ErrorCode { get; set; }
		
        /// <summary>
        /// String description of occured critical error. Empty if no critical errors occured
        /// </summary>  
        public string ErrorText { get; set; }
		
        /// <summary>
        /// Payload
        /// </summary>  
        public Payload Payload { get; set; }
		
        /// <summary>
        /// Server statistics
        /// </summary>  
        public ServerStat ServerStat { get; set; }
		
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class OmrResponse {\n");
          sb.Append("  ErrorCode: ").Append(this.ErrorCode).Append("\n");
          sb.Append("  ErrorText: ").Append(this.ErrorText).Append("\n");
          sb.Append("  Payload: ").Append(this.Payload).Append("\n");
          sb.Append("  ServerStat: ").Append(this.ServerStat).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
