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

// ReceptkaView.cpp : implementation of the CReceptkaView class
//

#include "stdafx.h"
// SHARED_HANDLERS can be defined in an ATL project implementing preview, thumbnail
// and search filter handlers and allows sharing of document code with that project.
#ifndef SHARED_HANDLERS
#include "Receptka.h"
#endif

#include "ReceptkaSet.h"
#include "ReceptkaDoc.h"
#include "ReceptkaView.h"
#include "FindDialog.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// CReceptkaView

IMPLEMENT_DYNCREATE(CReceptkaView, CRecordView)

BEGIN_MESSAGE_MAP(CReceptkaView, CRecordView)
	// Standard printing commands
	ON_COMMAND(ID_FILE_PRINT, &CRecordView::OnFilePrint)
	ON_COMMAND(ID_FILE_PRINT_DIRECT, &CRecordView::OnFilePrint)
	ON_COMMAND(ID_FILE_PRINT_PREVIEW, &CReceptkaView::OnFilePrintPreview)
	ON_WM_CONTEXTMENU()
	ON_WM_RBUTTONUP()
	ON_COMMAND(ID_PACJENT_NEW, &CReceptkaView::OnPacjentNew)
	ON_BN_CLICKED(ID_CHOICE1, &CReceptkaView::OnBnClickedChoice1)
	ON_BN_CLICKED(ID_CHOICE2, &CReceptkaView::OnBnClickedChoice2)
	ON_BN_CLICKED(IDC_PACJENT_ED, &CReceptkaView::OnBnClickedPacjentEd)
	ON_BN_CLICKED(IDC_PACJENT_DJN, &CReceptkaView::OnBnClickedPacjentDjn)
	ON_COMMAND(ID_PACJENT_DEL, &CReceptkaView::OnPacjentDel)
	ON_COMMAND(ID_PACJENT_ED, &CReceptkaView::OnBnClickedPacjentEd)
	ON_COMMAND(ID_PACJENT_DJN, &CReceptkaView::OnBnClickedPacjentDjn)
	ON_COMMAND(ID_PACJENT_FIND, &CReceptkaView::OnPacjentFind)
END_MESSAGE_MAP()

// CReceptkaView construction/destruction

CReceptkaView::CReceptkaView()
	: CRecordView(CReceptkaView::IDD)
{
	m_pSet = NULL;
	// TODO: add construction code here

}

CReceptkaView::~CReceptkaView()
{
}

void CReceptkaView::DoDataExchange(CDataExchange* pDX)
{
	CRecordView::DoDataExchange(pDX);
	// you can insert DDX_Field* functions here to 'connect' your controls to the database fields, ex.
	DDX_FieldText(pDX, IDC_IMIE, m_pSet->m_Imi, m_pSet);
	DDX_FieldText(pDX, IDC_NAZWISKO, m_pSet->m_Nazwisko, m_pSet);
	DDX_FieldText(pDX, IDC_ADRES, m_pSet->m_Adres, m_pSet);
	DDX_FieldText(pDX, IDC_PESEL, m_pSet->m_PESEL, m_pSet);
	DDX_FieldText(pDX, IDC_KCH, m_pSet->m_numer, m_pSet);
	// DDX_FieldCheck(pDX, IDC_MYCHECKBOX, m_pSet->m_bColumn2, m_pSet);
	// See MSDN and ODBC samples for more information
	DDX_Control(pDX, IDC_IMIE, m_oImie);
	DDX_Control(pDX, IDC_NAZWISKO, m_oNazw);
	DDX_Control(pDX, IDC_ADRES, m_oAdr);
	DDX_Control(pDX, IDC_PESEL, m_oPES);
	DDX_Control(pDX, IDC_KCH, m_oIC);

	DDX_Control(pDX, ID_CHOICE1, m_oChoice1);
	DDX_Control(pDX, ID_CHOICE2, m_oChoice2);
	
	DDX_Control(pDX, IDC_PACJENT_ED, m_oUpdate);
	DDX_Control(pDX, IDC_PACJENT_DJN, m_UpAsNew);

	m_pDocument->SetTitle(m_pSet->m_Imi + _T(" ") + m_pSet->m_Nazwisko);
}

BOOL CReceptkaView::PreCreateWindow(CREATESTRUCT& cs)
{
	// TODO: Modify the Window class or styles here by modifying
	//  the CREATESTRUCT cs

	return CRecordView::PreCreateWindow(cs);
}

void CReceptkaView::OnInitialUpdate()
{
	m_pSet = &GetDocument()->m_ReceptkaSet;
	CRecordView::OnInitialUpdate();

}


// CReceptkaView printing


void CReceptkaView::OnFilePrintPreview()
{
#ifndef SHARED_HANDLERS
	AFXPrintPreview(this);
#endif
}

BOOL CReceptkaView::OnPreparePrinting(CPrintInfo* pInfo)
{
	// default preparation
	return DoPreparePrinting(pInfo);
}

void CReceptkaView::OnBeginPrinting(CDC* /*pDC*/, CPrintInfo* /*pInfo*/)
{
	// TODO: add extra initialization before printing
}

void CReceptkaView::OnEndPrinting(CDC* /*pDC*/, CPrintInfo* /*pInfo*/)
{
	// TODO: add cleanup after printing
}

void CReceptkaView::OnRButtonUp(UINT /* nFlags */, CPoint point)
{
	ClientToScreen(&point);
	OnContextMenu(this, point);
}

void CReceptkaView::OnContextMenu(CWnd* /* pWnd */, CPoint point)
{
#ifndef SHARED_HANDLERS
	theApp.GetContextMenuManager()->ShowPopupMenu(IDR_POPUP_EDIT, point.x, point.y, this, TRUE);
#endif
}


// CReceptkaView diagnostics

#ifdef _DEBUG
void CReceptkaView::AssertValid() const
{
	CRecordView::AssertValid();
}

void CReceptkaView::Dump(CDumpContext& dc) const
{
	CRecordView::Dump(dc);
}

CReceptkaDoc* CReceptkaView::GetDocument() const // non-debug version is inline
{
	ASSERT(m_pDocument->IsKindOf(RUNTIME_CLASS(CReceptkaDoc)));
	return (CReceptkaDoc*)m_pDocument;
}
#endif //_DEBUG


// CReceptkaView database support
CRecordset* CReceptkaView::OnGetRecordset()
{
	return m_pSet;
}



// CReceptkaView message handlers


void CReceptkaView::OnPacjentNew()
{
	if (m_pSet->CanAppend() == 0)
	{ MessageBox(L"Nie mo¿na dodawac ani edytowac pacjentow.\nBaza danych jest tylko do odczytu.",
	L"B³¹d bazy danych", MB_OK | MB_ICONERROR);}
	else
	{
		m_oChoice1.SetWindowText(L"Dodaj");
		m_oChoice2.SetWindowText(L"Anuluj");

		m_oChoice1.ShowWindow(SW_SHOW);
		m_oChoice2.ShowWindow(SW_SHOW);
		m_oUpdate.ShowWindow(SW_HIDE);
		m_UpAsNew.ShowWindow(SW_HIDE);

		
		m_oImie.SetWindowText(L"");
		m_oNazw.SetWindowText(L"");
		m_oAdr.SetWindowText(L"");
		m_oPES.SetWindowText(L"");
		m_oIC.SetWindowText(L"");
	}


}


void CReceptkaView::OnBnClickedChoice1()
{
	CString		cValue;
	
	m_pSet->AddNew();
	m_oImie.GetWindowText(cValue);
	m_pSet->m_Imi = cValue;
	m_oNazw.GetWindowText(cValue);
	m_pSet->m_Nazwisko = cValue;
	m_oAdr.GetWindowText(cValue);
	m_pSet->m_Adres = cValue;
	m_oPES.GetWindowText(cValue);
	m_pSet->m_PESEL = cValue;
	m_oIC.GetWindowText(cValue);
	m_pSet->m_numer = cValue;

	m_pSet->Update();

	m_pSet->MoveLast();

	m_oChoice1.ShowWindow(SW_HIDE);
	m_oChoice2.ShowWindow(SW_HIDE);
	m_oUpdate.ShowWindow(SW_SHOW);
	m_UpAsNew.ShowWindow(SW_SHOW);

}


void CReceptkaView::OnBnClickedChoice2()
{
	m_oChoice1.ShowWindow(SW_HIDE);
	m_oChoice2.ShowWindow(SW_HIDE);
	m_oUpdate.ShowWindow(SW_SHOW);
	m_UpAsNew.ShowWindow(SW_SHOW);

	m_oImie.SetWindowText(m_pSet->m_Imi);
	m_oNazw.SetWindowText(m_pSet->m_Nazwisko);
	m_oAdr.SetWindowText(m_pSet->m_Adres);
	m_oPES.SetWindowText(m_pSet->m_PESEL);
	m_oIC.SetWindowText(m_pSet->m_numer);
}


void CReceptkaView::OnBnClickedPacjentEd()
{
	CString		cValue;
	m_pSet->Edit();
	m_oImie.GetWindowText(cValue);
	m_pSet->m_Imi = cValue;
	m_oNazw.GetWindowText(cValue);
	m_pSet->m_Nazwisko = cValue;
	m_oAdr.GetWindowText(cValue);
	m_pSet->m_Adres = cValue;
	m_oPES.GetWindowText(cValue);
	m_pSet->m_PESEL = cValue;
	m_oIC.GetWindowText(cValue);
	m_pSet->m_numer = cValue;

	m_pSet->Update();
}


void CReceptkaView::OnBnClickedPacjentDjn()
{
	CString		cValue;
	
	m_pSet->AddNew();
	m_oImie.GetWindowText(cValue);
	m_pSet->m_Imi = cValue;
	m_oNazw.GetWindowText(cValue);
	m_pSet->m_Nazwisko = cValue;
	m_oAdr.GetWindowText(cValue);
	m_pSet->m_Adres = cValue;
	m_oPES.GetWindowText(cValue);
	m_pSet->m_PESEL = cValue;
	m_oIC.GetWindowText(cValue);
	m_pSet->m_numer = cValue;

	m_pSet->Update();

	m_pSet->MoveLast();
}


void CReceptkaView::OnPacjentDel()
{
	int wynik = MessageBox(L"Czy napewno chcesz usunac tego pacjenta z bazy danych?", L"Receptka", MB_ICONQUESTION | MB_YESNO);
		if(wynik == IDYES) {
				m_pSet->Delete();
		}
}


void CReceptkaView::OnPacjentFind()
{
	CString nazw;
	CString unazw;
	CFindDialog oFindRec;
	BOOL lFound = FALSE;
	CDBVariant varBookmark;
	if (oFindRec.DoModal() == IDOK)
	{
		if (m_pSet->CanBookmark())
			m_pSet->GetBookmark(varBookmark);

		m_pSet->MoveFirst();
		while (!m_pSet->IsEOF() ^ lFound)
		{
			nazw = m_pSet->m_Nazwisko.MakeLower();
			unazw = m_pSet->m_Nazwisko.MakeUpper();
			//////////////////////////////////
			if (m_pSet->m_Nazwisko == oFindRec.m_oFind)
				lFound = TRUE;
			if (nazw == oFindRec.m_oFind)
				lFound = TRUE;
			if (unazw == oFindRec.m_oFind)
				lFound = TRUE;
			///////////////////////////////////////////////
			else if(m_pSet->m_PESEL == oFindRec.m_oFind)
				lFound = TRUE;
			else if(m_pSet->m_PESEL.Left(6) == oFindRec.m_oFind)
				lFound = TRUE;
			else
				m_pSet->MoveNext();
		}
		if (!lFound)
		{
			MessageBox(L"Nie ma pacjenta z takim nazwiskiem\nlub peselem w bazie danych", L"Receptka", MB_OK | MB_ICONINFORMATION);
			if (m_pSet->CanBookmark())
				m_pSet->SetBookmark(varBookmark);
			else
				m_pSet->MoveFirst();
		}
		else
		{
			m_oImie.SetWindowText(m_pSet->m_Imi);
			m_oNazw.SetWindowText(m_pSet->m_Nazwisko);
			m_oAdr.SetWindowText(m_pSet->m_Adres);
			m_oPES.SetWindowText(m_pSet->m_PESEL);
			m_oIC.SetWindowText(m_pSet->m_numer);
		}
	}

}
void CReceptkaView::OnPrint(CDC* pDC, CPrintInfo* pInfo)
{
		LOGFONT lFont;
	int Y = 550;
	int X = 50;
	int iNazwPos;
	CRect oDrawRect;
	oDrawRect = pInfo->m_rectDraw;
	CFont oFont;
	lFont.lfWeight = 700;
	oFont.CreateFontIndirect(&lFont);
	oFont.CreatePointFont(120, L"Times New Roman", pDC);
	pDC->SelectObject(&oFont);
	//iNazwPos = X + 40 + pDC->GetOutputTextExtent(m_pSet->m_Imi).cx;
	pDC->TextOut(X, Y, m_pSet->m_Imi + " " + m_pSet->m_Nazwisko);
	//pDC->TextOut(iNazwPos, height, m_pSet->m_Nazwisko);
	pDC->TextOut(X + 1000, Y - 100, m_pSet->m_numer);
	Y += pDC->GetOutputTextExtent(L"##").cy;
	pDC->TextOut(X, Y, m_pSet->m_Adres);
	Y += 140;
	X += pDC->GetOutputTextExtent(L"Pesel: ").cx;
	pDC->TextOut(X, Y, m_pSet->m_PESEL);

	CRecordView::OnPrint(pDC, pInfo);
}