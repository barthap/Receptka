// This MFC Samples source code demonstrates using MFC Microsoft Office Fluent User Interface 
// (the "Fluent UI") and is provided only as referential material to supplement the 
// Microsoft Foundation Classes Reference and related electronic documentation 
// included with the MFC C++ library software.  
// License terms to copy, use or distribute the Fluent UI are available separately.  
// To learn more about our Fluent UI licensing program, please visit 
// http://msdn.microsoft.com/officeui.
//
// Copyright (C) Microsoft Corporation
// All rights reserved.

// ReceptkaSet.cpp : implementation of the CReceptkaSet class
//

#include "stdafx.h"
#include "Receptka.h"
#include "ReceptkaSet.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// CReceptkaSet implementation

// code generated on 6 kwietnia 2010, 09:39

IMPLEMENT_DYNAMIC(CReceptkaSet, CRecordset)

CReceptkaSet::CReceptkaSet(CDatabase* pdb)
	: CRecordset(pdb)
{
	m_Imi = L"";
	m_Nazwisko = L"";
	m_Adres = L"";
	m_PESEL = L"";
	m_numer = L"";
	m_nFields = 5;
	m_nDefaultType = dynaset;
}
// The connection string below may contain plain text passwords and/or
// other sensitive information. Please remove the #error after reviewing
// the connection string for any security related issues. You may want to
// store the password in some other form or use a different user authentication.
CString CReceptkaSet::GetDefaultConnect()
{
	return _T("DBQ=C:\\Windows\\System32\\pacjenci.mdb;DefaultDir=C:\\Windows\\System32;Driver={Driver do Microsoft Access (*.mdb)};DriverId=25;FIL=MS Access;FILEDSN=C:\\Windows\\System32\\pacjenci.dsn;MaxBufferSize=2048;MaxScanRows=8;PageTimeout=5;PWD=qvm99ihd;SafeTransactions=0;Threads=3;UID=admin;UserCommitSync=Yes;");
}

CString CReceptkaSet::GetDefaultSQL()
{
	return _T("[pacjenci]");
}

void CReceptkaSet::DoFieldExchange(CFieldExchange* pFX)
{
	pFX->SetFieldType(CFieldExchange::outputColumn);
// Macros such as RFX_Text() and RFX_Int() are dependent on the
// type of the member variable, not the type of the field in the database.
// ODBC will try to automatically convert the column value to the requested type
	RFX_Text(pFX, _T("[Imiê]"), m_Imi);
	RFX_Text(pFX, _T("[Nazwisko]"), m_Nazwisko);
	RFX_Text(pFX, _T("[Adres]"), m_Adres);
	RFX_Text(pFX, _T("[PESEL]"), m_PESEL);
	RFX_Text(pFX, _T("[numer]"), m_numer);

}
/////////////////////////////////////////////////////////////////////////////
// CReceptkaSet diagnostics

#ifdef _DEBUG
void CReceptkaSet::AssertValid() const
{
	CRecordset::AssertValid();
}

void CReceptkaSet::Dump(CDumpContext& dc) const
{
	CRecordset::Dump(dc);
}
#endif //_DEBUG

