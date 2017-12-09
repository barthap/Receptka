#if !defined(AFX_MYEDITCTRL_H__77B0F921_463A_11D2_BE76_0080ADB7F1BB__INCLUDED_)
#define AFX_MYEDITCTRL_H__77B0F921_463A_11D2_BE76_0080ADB7F1BB__INCLUDED_

#if _MSC_VER >= 1000
#pragma once
#endif // _MSC_VER >= 1000

/////////////////////////////////////////////////////////////////////////////
// CMyEdit window

class CMyEdit : public CEdit
{
// Construction
public:
 CMyEdit();

// Attributes
public:

// Operations
public:

// Overrides
// ClassWizard generated virtual function overrides
//{{AFX_VIRTUAL(CMyEdit)
public:
 virtual BOOL PreTranslateMessage(MSG* pMsg);
//}}AFX_VIRTUAL

// Implementation
public:
 virtual ~CMyEdit();

// Generated message map functions
protected:
//{{AFX_MSG(CMyEdit)
//}}AFX_MSG

DECLARE_MESSAGE_MAP()
};

/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Developer Studio will insert additional declarations immediately before
//previous line.

#endif // !defined(AFX_MYEDITCTRL_H__77B0F921_463A_11D2_BE76_0080ADB7F1BB__INCLUDED_)

