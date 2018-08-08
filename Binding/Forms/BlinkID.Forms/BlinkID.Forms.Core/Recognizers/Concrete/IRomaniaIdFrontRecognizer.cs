﻿namespace Microblink.Forms.Core.Recognizers
{
    /// <summary>
    ///  Recognizer for front side of Romanian ID.
    /// 
    /// </summary>
    public interface IRomaniaIdFrontRecognizer : IRecognizer
    {
        
        /// <summary>
        /// Defines whether glare detector is enabled. 
        ///
        /// By default, this is set to 'true'
        /// </summary>
        bool DetectGlare { get; set; }
        
        /// <summary>
        /// true if address is being extracted from Romanian ID 
        ///
        /// By default, this is set to 'true'
        /// </summary>
        bool ExtractAddress { get; set; }
        
        /// <summary>
        /// true if first name is being extracted from Romanian ID 
        ///
        /// By default, this is set to 'true'
        /// </summary>
        bool ExtractFirstName { get; set; }
        
        /// <summary>
        /// true if issuing authority is being extracted from Romanian ID 
        ///
        /// By default, this is set to 'true'
        /// </summary>
        bool ExtractIssuedBy { get; set; }
        
        /// <summary>
        /// true if last name is being extracted from Romanian ID 
        ///
        /// By default, this is set to 'true'
        /// </summary>
        bool ExtractLastName { get; set; }
        
        /// <summary>
        /// true if sex field outside of the MRZ is being extracted from Romanian ID 
        ///
        /// By default, this is set to 'true'
        /// </summary>
        bool ExtractNonMRZSex { get; set; }
        
        /// <summary>
        /// true if place of birth is being extracted from Romanian ID 
        ///
        /// By default, this is set to 'true'
        /// </summary>
        bool ExtractPlaceOfBirth { get; set; }
        
        /// <summary>
        /// true if valid from is being extracted from Romanian ID 
        ///
        /// By default, this is set to 'true'
        /// </summary>
        bool ExtractValidFrom { get; set; }
        
        /// <summary>
        /// true if valid until is being extracted from Romanian ID 
        ///
        /// By default, this is set to 'true'
        /// </summary>
        bool ExtractValidUntil { get; set; }
        
        /// <summary>
        /// Defines whether face image will be available in result. 
        ///
        /// By default, this is set to 'false'
        /// </summary>
        bool ReturnFaceImage { get; set; }
        
        /// <summary>
        /// Defines whether full document image will be available in result. 
        ///
        /// By default, this is set to 'false'
        /// </summary>
        bool ReturnFullDocumentImage { get; set; }
        

        /// <summary>
        /// Gets the result.
        /// </summary>
        IRomaniaIdFrontRecognizerResult Result { get; }
    }

    /// <summary>
    /// Result object for IRomaniaIdFrontRecognizer.
    /// </summary>
    public interface IRomaniaIdFrontRecognizerResult : IRecognizerResult {
        
        /// <summary>
        /// address of the Romanian ID owner. 
        /// </summary>
        string Address { get; }
        
        /// <summary>
        /// the card number of Romanian ID. 
        /// </summary>
        string CardNumber { get; }
        
        /// <summary>
        /// the CNP of Romanian ID owner. 
        /// </summary>
        string Cnp { get; }
        
        /// <summary>
        /// Defines holder's date of birth if it is successfully converted to result from MRZ date format: <code>YYMMDD</code>. 
        /// </summary>
        IDate DateOfBirth { get; }
        
        /// <summary>
        /// Defines date of expiry if it is successfully converted to result from MRZ date format: <code>YYMMDD</code>. 
        /// </summary>
        IDate DateOfExpiry { get; }
        
        /// <summary>
        /// Defines document code. Document code contains two characters. For MRTD the first character shall 
        /// </summary>
        string DocumentCode { get; }
        
        /// <summary>
        /// Defines document number. Document number contains up to 9 characters. 
        /// </summary>
        string DocumentNumber { get; }
        
        /// <summary>
        ///  face image from the document 
        /// </summary>
        Xamarin.Forms.ImageSource FaceImage { get; }
        
        /// <summary>
        /// the first name of the Romanian ID owner. 
        /// </summary>
        string FirstName { get; }
        
        /// <summary>
        ///  image of the full document 
        /// </summary>
        Xamarin.Forms.ImageSource FullDocumentImage { get; }
        
        /// <summary>
        /// the identity card series of Romanian ID. 
        /// </summary>
        string IdSeries { get; }
        
        /// <summary>
        /// issuing authority the Romanian ID. 
        /// </summary>
        string IssuedBy { get; }
        
        /// <summary>
        /// Defines three-letter or two-letter code which indicate the issuing State. Three-letter codes are based 
        /// </summary>
        string Issuer { get; }
        
        /// <summary>
        /// the last name of the Romanian ID owner. 
        /// </summary>
        string LastName { get; }
        
        /// <summary>
        /// Defines true if Machine Readable Zone has been parsed, false otherwise. 
        /// </summary>
        bool MrzParsed { get; }
        
        /// <summary>
        /// Defines the entire Machine Readable Zone text from ID. This text is usually used for parsing 
        /// </summary>
        string MrzText { get; }
        
        /// <summary>
        /// Defines true if all check digits inside MRZ are correct, false otherwise. 
        /// </summary>
        bool MrzVerified { get; }
        
        /// <summary>
        /// Defines nationality of the holder represented by a three-letter or two-letter code. Three-letter 
        /// </summary>
        string Nationality { get; }
        
        /// <summary>
        /// nationality of the Romanian ID owner which is extracted from the non MRZ field. 
        /// </summary>
        string NonMRZNationality { get; }
        
        /// <summary>
        /// sex of the Romanian ID owner which is extracted from the non MRZ field. 
        /// </summary>
        string NonMRZSex { get; }
        
        /// <summary>
        /// Defines first optional data.<code>null</code> or empty string if not available. 
        /// </summary>
        string Opt1 { get; }
        
        /// <summary>
        /// Defines second optional data.<code>null</code> or empty string if not available. 
        /// </summary>
        string Opt2 { get; }
        
        /// <summary>
        /// the parent names of Romanian ID owner. 
        /// </summary>
        string ParentNames { get; }
        
        /// <summary>
        /// place of birth of the Romanian ID owner. 
        /// </summary>
        string PlaceOfBirth { get; }
        
        /// <summary>
        /// Defines the primary indentifier. If there is more than one component, they are separated with space. 
        /// </summary>
        string PrimaryId { get; }
        
        /// <summary>
        /// Defines the secondary identifier. If there is more than one component, they are separated with space. 
        /// </summary>
        string SecondaryId { get; }
        
        /// <summary>
        /// Defines sex of the card holder. Sex is specified by use of the single initial, 
        /// </summary>
        string Sex { get; }
        
        /// <summary>
        /// the valid from date of Romanian ID. 
        /// </summary>
        IDate ValidFrom { get; }
        
        /// <summary>
        /// the valid until date of Romanian ID. 
        /// </summary>
        IDate ValidUntil { get; }
        
    }
}