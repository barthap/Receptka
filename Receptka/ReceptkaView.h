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

// ReceptkaView.h : interface of the CReceptkaView class
//
#include "uedit.h"

#pragma once

class CReceptkaSet;

class CReceptkaView : public CRecordView
{
protected: // create from serialization only
	CReceptkaView();
	DECLARE_DYNCREATE(CReceptkaView)

public:
	enum{ IDD = IDD_RECEPTKA_FORM };
	CReceptkaSet* m_pSet;

// Attributes
public:
	CReceptkaDoc* GetDocument() const;

// Operations
public:

// Overrides
public:
	virtual CRecordset* OnGetRecordset();
	virtual BOOL PreCreateWindow(CREATESTRUCT& cs);
protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	virtual void OnInitialUpdate(); // called first time after construct
	virtual BOOL OnPreparePrinting(CPrintInfo* pInfo);
	virtual void OnBeginPrinting(CDC* pDC, CPrintInfo* pInfo);
	virtual void OnEndPrinting(CDC* pDC, CPrintInfo* pInfo);
	virtual void OnPrint(CDC* pDC, CPrintInfo* pInfo);

// Implementation
public:
	virtual ~CReceptkaView();	
#ifdef _DEBUG
	virtual void AssertValid() const;
	virtual void Dump(CDumpContext& dc) const;
#endif

protected:

// Generated message map functions
protected:
	afx_msg void OnFilePrintPreview();
	afx_msg void OnRButtonUp(UINT nFlags, CPoint point);
	afx_msg void OnContextMenu(CWnd* pWnd, CPoint point);
	DECLARE_MESSAGE_MAP()
public:
	CMyEdit m_oImie;
	CMyEdit m_oNazw;
	CEdit m_oAdr;
	CEdit m_oPES;
	CEdit m_oIC;
	CMFCButton m_oChoice1;
	CMFCButton m_oChoice2;
	CMFCButton m_oUpdate;
	CMFCButton m_UpAsNew;

	afx_msg void OnPacjentNew();
	afx_msg void OnBnClickedChoice1();
	afx_msg void OnBnClickedChoice2();
	afx_msg void OnBnClickedPacjentEd();
	afx_msg void OnBnClickedPacjentDjn();
	afx_msg void OnPacjentDel();
	afx_msg void OnPacjentFind();
};

#ifndef _DEBUG  // debug version in ReceptkaView.cpp
inline CReceptkaDoc* CReceptkaView::GetDocument() const
   { return reinterpret_cast<CReceptkaDoc*>(m_pDocument); }
#endif

