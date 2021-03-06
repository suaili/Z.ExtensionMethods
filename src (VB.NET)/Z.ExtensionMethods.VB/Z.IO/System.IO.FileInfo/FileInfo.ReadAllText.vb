
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.IO
Imports System.Text

Public Module Extensions_788

	''' <summary>
	'''     Opens a text file, reads all lines of the file, and then closes the file.
	''' </summary>
	''' <param name="this">The file to open for reading.</param>
	''' <returns>A string containing all lines of the file.</returns>
	''' ###
	''' <exception cref="T:System.ArgumentException">
	'''     <paramref name="this" /> is a zero-length string, contains only
	'''     white space, or contains one or more invalid characters as defined by
	'''     <see
	'''         cref="F:System.IO.Path.InvalidPathChars" />
	'''     .
	''' </exception>
	''' ###
	''' <exception cref="T:System.ArgumentNullException">
	'''     <paramref name="this" /> is null.
	''' </exception>
	''' ###
	''' <exception cref="T:System.IO.PathTooLongException">
	'''     The specified @this, file name, or both exceed the system-
	'''     defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file
	'''     names must be less than 260 characters.
	''' </exception>
	''' ###
	''' <exception cref="T:System.IO.DirectoryNotFoundException">
	'''     The specified @this is invalid (for example, it is on
	'''     an unmapped drive).
	''' </exception>
	''' ###
	''' <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.</exception>
	''' ###
	''' <exception cref="T:System.UnauthorizedAccessException">
	'''     <paramref name="this" /> specified a file that is
	'''     read-only.-or- This operation is not supported on the current platform.-or-
	'''     <paramref
	'''         name="this" />
	'''     specified a directory.-or- The caller does not have the required permission.
	''' </exception>
	''' ###
	''' <exception cref="T:System.IO.FileNotFoundException">
	'''     The file specified in <paramref name="this" /> was not
	'''     found.
	''' </exception>
	''' ###
	''' <exception cref="T:System.NotSupportedException">
	'''     <paramref name="this" /> is in an invalid format.
	''' </exception>
	''' ###
	''' <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ReadAllText(this As FileInfo) As [String]
		Return File.ReadAllText(this.FullName)
	End Function

	''' <summary>
	'''     Opens a file, reads all lines of the file with the specified encoding, and then closes the file.
	''' </summary>
	''' <param name="this">The file to open for reading.</param>
	''' <param name="encoding">The encoding applied to the contents of the file.</param>
	''' <returns>A string containing all lines of the file.</returns>
	''' ###
	''' <exception cref="T:System.ArgumentException">
	'''     <paramref name="this" /> is a zero-length string, contains only
	'''     white space, or contains one or more invalid characters as defined by
	'''     <see
	'''         cref="F:System.IO.Path.InvalidPathChars" />
	'''     .
	''' </exception>
	''' ###
	''' <exception cref="T:System.ArgumentNullException">
	'''     <paramref name="this" /> is null.
	''' </exception>
	''' ###
	''' <exception cref="T:System.IO.PathTooLongException">
	'''     The specified @this, file name, or both exceed the system-
	'''     defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file
	'''     names must be less than 260 characters.
	''' </exception>
	''' ###
	''' <exception cref="T:System.IO.DirectoryNotFoundException">
	'''     The specified @this is invalid (for example, it is on
	'''     an unmapped drive).
	''' </exception>
	''' ###
	''' <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.</exception>
	''' ###
	''' <exception cref="T:System.UnauthorizedAccessException">
	'''     <paramref name="this" /> specified a file that is
	'''     read-only.-or- This operation is not supported on the current platform.-or-
	'''     <paramref
	'''         name="this" />
	'''     specified a directory.-or- The caller does not have the required permission.
	''' </exception>
	''' ###
	''' <exception cref="T:System.IO.FileNotFoundException">
	'''     The file specified in <paramref name="this" /> was not
	'''     found.
	''' </exception>
	''' ###
	''' <exception cref="T:System.NotSupportedException">
	'''     <paramref name="this" /> is in an invalid format.
	''' </exception>
	''' ###
	''' <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ReadAllText(this As FileInfo, encoding As Encoding) As [String]
		Return File.ReadAllText(this.FullName, encoding)
	End Function
End Module


