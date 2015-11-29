using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Hjg.Pngcs;
using Hjg.Pngcs.Chunks;

[System.Serializable]
public class FullColorImage
{
	static public FullColorImage LoadImage( string _path, PalettizedImageConfig _config )
	{
		string ext = System.IO.Path.GetExtension( _path ).ToLower();
		if( ext.Equals( ".png" ))
			return LoadPNG( _path, _config );
		
		return null;
	}
	
	static public FullColorImage LoadPNG( string _path, PalettizedImageConfig _config )
	{
		PngReader pngr = FileHelper.CreatePngReader( _path );
		if( pngr.ImgInfo.Indexed )
		{
			Debug.LogException( new UnityException( "Image is indexed" ));
			return null;
		}

		Debug.Log ("Image BPP=" + pngr.ImgInfo.BitspPixel );
		/*
		PngChunkPLTE palette = pngr.GetMetadata().GetPLTE();
		
		PalettizedImage image = new PalettizedImage( pngr.ImgInfo.Cols, pngr.ImgInfo.Rows, palette.GetNentries());
		image.SetConfig( _config );
		image.m_fileName = System.IO.Path.GetFileNameWithoutExtension( _path );
		
		image.ReadPalette( palette );
		image.ReadImage( pngr );

		return image;
		*/
		return null;
	}
	
	FullColorImage( int _width, int _height, int _coloursInPalette )
	{
//		m_width = _width;
//		m_height = _height;
//		m_palette = new List<Color>();
//		m_colorUsed = new List<bool>();
//		m_image = new byte[ m_width * m_height ];
//		m_coloursInPalette = _coloursInPalette;
	}
	
}
